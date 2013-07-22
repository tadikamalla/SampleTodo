(function() {

  window.app = window.app || {};

  app.controllers = app.controllers || {};

  app.controllers.ToDoController = function($scope, $http) {
    var fetch, save;
    $scope.createTask = function() {
      save({
        task: $scope.Task
      });
      $scope.Task = "";
    };
    $scope.markDone = function(index) {
      var todo;
      todo = $scope.todos[index];
      save(todo);
    };
    save = function(todo) {
      $http.post("/api/todos", todo).success(function() {
        fetch();
      });
    };
    fetch = function() {
      $http.get("/api/todos").success(function(data) {
        $scope.todos = data;
      });
    };
    fetch();
  };

}).call(this);
