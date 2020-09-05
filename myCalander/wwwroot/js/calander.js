
function fetchTasks() {
// crate and get ajax req to /api/tasks
// console log the response form the server
$.ajax({
    type: 'GET',
    url: '/api/tasks',
    sucess: (res) => {
        console.log(res);
        for(let i=0; i< res.length; i++){

    displayTask(res[i]);
    }    

},

    error: (details) => {
        console.log("error", details);
    }

});

}
function displayTask(task) {
    var container = $("#tasks");

    var syntax = `
    <div class='task'>
        <i class="far fa-circle check"></i> 
        <div class='task-content'>
            <h5 class='task-title'>${task.title}</h5>
            <label class='task-notes'>${tasks.notes}</label>
        </div>
        <i class='fas fa-star'></i>
    </div>
`;

    container.append(syntax);
}

function init(){
    console.log("MyCalaender page");
}


window.onlad = init;