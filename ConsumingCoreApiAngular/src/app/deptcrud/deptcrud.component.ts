import { Component, OnInit } from '@angular/core';
import { Department } from 'src/Models/Department';
import { DepartmentService } from 'src/Service/departmentService';

@Component({
  selector: 'app-deptcrud',
  templateUrl: './deptcrud.component.html',
  styleUrls: ['./deptcrud.component.css']
})
export class DeptcrudComponent implements OnInit {

  constructor(private deptservice:DepartmentService) { }

  ngOnInit() {
    this.fetchdept();
  }


  //call the getdept from departmentservice
  department:Department;

  errmsg;
  fetchdept()
  {
    debugger;
    this.deptservice.getDept().subscribe((data)=>{console.table(data);this.department=data},
    (err)=>{this.errmsg=err.error.Message; //error handling
    
    }
    );
  }
  //call deletedept from departmentservice

  message;
  removeDept(id?:number)
  {
    debugger;
      this.deptservice.deleteDept(id).subscribe((data)=>{this.message=data});
  }

  //call insertdept from departmentservice
  dept:Department={};
  addDept()
  {
    debugger;
    this.deptservice.insertDept(this.dept).subscribe((data)=>this.message=data);
//to avoid reloading to see the inserted record in table
this.fetchdept();

  }
//call  getdeptbyid from departmentservice

getdeptid(id?:number)
{
  debugger;
  this.deptservice.getdeptbyid(id).subscribe((data)=>this.dept=data)

}

//call putdept from departmentservice

updateDept(de:Department)
{
  this.deptservice.putDept(de).subscribe((data)=>this.message=data);
}
}
