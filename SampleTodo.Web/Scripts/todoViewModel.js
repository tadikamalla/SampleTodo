var viewModel = {
    list: ko.observableArray(),
    getList: function () {
        $.get("api/Todos", function (data) {
            viewModel.list(data);
        });
    },
    addTask: function () {
        var todo = { Id: 0, Task: $("#txtTask").val(), IsComplete: false };
        $.ajax({
            url: "api/Todos",
            type: "PUT",
            data: JSON.stringify(todo),
            contentType:"application/json",
            success: function () {
                viewModel.getList();
            }
        });
    },
    updateTask: function (task) {
        var todo = { Id: task.Id, Task: task.Task, IsComplete: task.IsComplete};
        $.ajax({
            url: "api/Todos",
            type: "POST",
            data: JSON.stringify(todo),
            contentType: "application/json",
            success: function (data) {
                viewModel.getList();
            }
        });
        return true;
    }
};

$(function () {
    ko.applyBindings(viewModel);
    //on load get data and bind to template
    viewModel.getList();
});
