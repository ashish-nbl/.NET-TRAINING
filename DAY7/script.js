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
  let taskName = document.getElementById("taskName").value;
  if(taskName==='')
  {
    alert("Task Title is required");
    return;
  }
  console.log("taskname:" + taskName);

  let taskPriority = document.getElementById("task").value;
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
  renderTask();
}

let taskContainer = document.getElementById("taskContainer");
function renderTask(tasks = taskArray) {
  taskContainer.innerHTML = "";
  let taskList = tasks.forEach((task) => {
    let card = document.createElement("div");
    card.classList.add("task-card");

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
      let inx = taskArray.indexOf(task);
      if (inx !== -1) {
        taskArray.splice(inx, 1);
        localStorage.setItem("tasksData", JSON.stringify(taskArray));
        renderTask();
      }
      console.log(taskArray);
    });

    card.appendChild(name);
    card.appendChild(priority);
    card.appendChild(createdDate);
    card.appendChild(status);
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
      card.appendChild(btn);
    }
    card.appendChild(deleteBtn);
    taskContainer.appendChild(card);

    console.log(taskArray);
  });
}

renderTask();

function titleChange(taskName)
{
  console.log(taskName);
  let filteredArray=taskArray.filter(task=>task.name.toLowerCase().includes(taskName.toLowerCase()))
 
  console.log(filteredArray);

  let messageExists=document.getElementById('not-found')
  if(filteredArray.length===0)
  {
    if(!messageExists)
    {
        let notFound=document.createElement('p');
        notFound.id='not-found'
        let body=document.body;
        notFound.innerText="Task Not Found"
        body.appendChild(notFound);
    }
  }
  renderTask(filteredArray);
}
