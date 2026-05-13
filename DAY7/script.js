console.log("Hello");

// let taskArray=[
//     {
//         name:"task1",
//         priority:"low",
//         createdDate:"Tue May 12 2026",
//         isCompleted:false
//     },
//     {
//         name:"task2",
//         priority:"medium",
//         createdDate:"Tue May 12 2026",
//         isCompleted:true
//     },
//     {
//         name:"task3",
//         priority:"high",
//         createdDate:"Tue May 12 2026",
//         isCompleted:true
//     }
// ];


let taskArray = JSON.parse(localStorage.getItem("tasksData")) || [];

let btnEl = document.getElementById("add-task");

function addValue() {
    let taskNameEl = document.getElementById("taskName");

  let taskPriorityEl = document.getElementById("task");


  let taskName = taskNameEl.value;
  if(taskName==='')
  {
    alert("Task Title is required");
    return;
  }
  console.log("taskname:" + taskName);

  let taskPriority = taskPriorityEl.value;
  console.log("priority:" + taskPriority);
  if(taskPriority==='')
  {
    alert("Task Priority is required");
    return;
  }

  let createdDate = new Date();
  console.log(createdDate.toDateString());

  taskArray.push({
    name: taskName,
    priority: taskPriority,
    createdDate: createdDate.toDateString(),
    isCompleted: false,
  });

  console.log(taskArray);

  localStorage.setItem("tasksData", JSON.stringify(taskArray));
  
   taskNameEl.value = '';
  taskPriorityEl.value = '';
  renderTask();
}

let taskContainer = document.getElementById("taskContainer");


function renderTask(tasks = taskArray) {
  taskContainer.innerHTML = "";
  let taskList = tasks.forEach((task) => {
    let card = document.createElement("div");
    card.classList.add("task-card");

    if(task.isCompleted)
    {
      card.id='completed-card'
    }

    let name = document.createElement("p");
    name.classList.add("task-title");
    name.textContent = task.name;

    let priority = document.createElement("p");
    priority.classList.add("task-priority");

    priority.innerHTML = `<strong>Priority:</strong> ${task.priority}`;

    let createdDate = document.createElement("p");
    createdDate.classList.add("task-date");

    createdDate.innerHTML = `<strong>Created:</strong> ${task.createdDate}`;

    let status = document.createElement("p");
    status.classList.add("task-status");

    status.innerHTML =
      `<strong>Status:</strong> ${
        task.isCompleted ? "Completed" : "Pending"
      }`;

      
    let deleteBtn = document.createElement("button");
    deleteBtn.textContent = "Delete";
    deleteBtn.classList.add("delete-btn");

    deleteBtn.addEventListener("click", () => {
      let wantToDelete=confirm("Are you sure to delete this task")
      if(wantToDelete)
      {
      let inx = taskArray.indexOf(task);
      if (inx !== -1) {
        taskArray.splice(inx, 1);
        localStorage.setItem("tasksData", JSON.stringify(taskArray));
        renderTask();
      }
    }
      console.log(taskArray);
    });

    card.append(name);
    card.append(priority);
    card.append(createdDate);
    card.append(status);
    if (!task.isCompleted) {
      let btn = document.createElement("button");
      btn.textContent = "Complete Task";
      btn.classList.add("complete-btn");


      btn.addEventListener("click", () => {
        task.isCompleted = !task.isCompleted;
        localStorage.setItem("tasksData", JSON.stringify(taskArray));
        renderTask();
        console.log(taskArray);
      });
      card.append(btn);
    }
    card.append(deleteBtn);
    taskContainer.append(card);
 
    console.log(taskArray);
  });
}

renderTask();

// function titleChange(taskName)
// {
//   console.log(taskName);
//   let filteredArray=taskArray.filter(task=>task.name.toLowerCase().includes(taskName.toLowerCase()))
 
//   console.log(filteredArray);

//   let messageExists=document.getElementById('not-found')
//   if(filteredArray.length===0)
//   {
//     if(!messageExists)
//     {
//         // let notFound=document.createElement('p');
//         // notFound.id='not-found'
//         // let body=document.body;
//         // notFound.innerText="Task Not Found"
//         // body.appendChild(notFound);

        

//     }
//   }
//   renderTask(filteredArray);
// }
function titleChange(taskName)
{
    console.log(taskName);

    let filteredArray = taskArray.filter(task =>
      task.name.toLowerCase().includes(taskName.toLowerCase())
    );
    
    renderTask(filteredArray);
    console.log(filteredArray);

    let messageExists = document.getElementById("not-found");

    if(messageExists){
        messageExists.remove();
    }

    if(filteredArray.length === 0 && taskName.trim() !== "")
    {
            showNotFoundMessage();

    }

}

function filterTasks(filterTask)
{

  console.log(filterTask);
  if(filterTask==="all")
  {
    renderTask();
  }
  else
  {
  let filteredTasks=taskArray.filter(task=>{
    let filteredName=task.isCompleted ? "completed" :"pending"
    return filteredName===filterTask;
  });
  console.log(filteredTasks);
  renderTask(filteredTasks);
  
  if(filteredTasks.length===0)
  {
    showNotFoundMessage();
  }
}
}


function showNotFoundMessage(){

    let existing = document.getElementById("not-found");

    if(!existing){

        let message = document.createElement("p");

        message.id = "not-found";

        message.innerText = "Task Not Found";

        taskContainer.append(message);
    }
}