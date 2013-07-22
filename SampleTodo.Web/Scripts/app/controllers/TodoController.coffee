window.app = window.app || {}
app.controllers = app.controllers || {}

app.controllers.ToDoController = ($scope, $http) -> 
    $scope.createTask = -> 
       save({ task: $scope.Task })
       $scope.Task = ""
       return

    $scope.markDone = (index) ->
        todo = $scope.todos[index]
        save(todo)
        return
    save = (todo) ->
        $http.post("/api/todos", todo).success(-> 
            fetch()
            return
        ) 
        return
    fetch = ->
        $http.get("/api/todos").success((data) ->
            $scope.todos = data;
            return
        )
        return

    fetch()
    return