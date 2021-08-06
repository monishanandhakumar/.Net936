import{Injectable} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Department } from 'src/Models/Department';

@Injectable({providedIn:"root"})
export class DepartmentService
{
    constructor(private http:HttpClient)
    {
       
    }

    readonly uri="https://localhost:44357/api/departments";

    //calling getdepartments method from API
    getDept()
    {
        debugger;
        return this.http.get(this.uri);
    }

    //delete

    deleteDept(id?:number)
    {
        debugger;
        return this.http.delete(this.uri+"/"+ id);
            
    }
    //Insert
    insertDept(dept:Department)
    {
        debugger;
        return this.http.post(this.uri,dept);
        
    }
    //fetch the partcilar department details to edit

    getdeptbyid(id)
    {
        debugger;
       return this.http.get(this.uri+"/"+ id)

    }
    //Update

    putDept(department:Department)
    {
          debugger;
          return this.http.put(this.uri+"/"+ department.deptid,department);
    }


}