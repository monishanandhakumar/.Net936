import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PrjMoreExample';
  //Eg1
  like:number;
  //Eg2
  togglestar:boolean;
  clsName:string;


  constructor()
  {
    //Eg1
    this.like=0;

    //Eg2
    this.togglestar=false;
    this.clsName='glyphicon glyphicon-star-empty'
  }
//Eg1
  thumbsUp()
  {
       this.like =this.like+1;
  }

  //Eg2
  changestar()
  {
    debugger;
    this.togglestar=!this.togglestar;
    if(this.togglestar)
    {
      this.clsName='glyphicon glyphicon-star'
    }
    else
    {
      this.clsName='glyphicon glyphicon-star-empty'
    }
  }
}
