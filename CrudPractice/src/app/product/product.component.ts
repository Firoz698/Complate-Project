import { Component, OnInit } from '@angular/core';
import { catchError } from 'rxjs';
import { AppServicesService } from '../app-services.service';
import { Users } from './Model/Users';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  //this Is the array data Store
  id:0;
  name:string="";
  age:0;
  address:string="";
  profation:string="";
  oUser = new Users();
  product :any[]=[];

  constructor(private apiInject: AppServicesService) { }

  ngOnInit(): void {
    //page load hobar shathe load hobar janno
    this.getUsrs();
  }

//button one au khan theke kaj korse
  addUser() {
    debugger
    this.oUser = new Users();
    this.oUser.id = this.id;
    this.oUser.name = this.name;
    this.oUser.age = this.age;
    this.oUser.address = this.address;
    this.oUser.profation = this.profation;
    debugger
    if (this.id > 0) {
      this.apiInject.putUser(this.oUser).subscribe(
        (res)=>{
          //alert("data save successfully")
          this.getUsrs();
        },
        (err)=>{
          alert(err.statusText) 
        }
      )
    }
    else {
      this.apiInject.postProduct(this.oUser).subscribe(
        (res)=>{
          //alert("data Update successfully")
          this.getUsrs();

        },
        (err)=>{
          alert(err.statusText) 
        }
      )
    }
    
  }

//DataBase Theke Product are moddhe assagin kora hossa
getUsrs() {
    this.apiInject.GetUsers().subscribe(
      (res)=>{
        this.product=res;
      },
      )
    }
      
  //this is a deleted button
  DeletedProduct(pro) {
    var ConfirmValue = confirm("Are You Sure You Want To Delet This Item!")
    if(ConfirmValue==true){
      debugger
    this.apiInject.deletedUser(pro.id).subscribe(
      (res)=>{
        console.log(res)
        this.getUsrs();
      },
      (err)=>{
        alert(err.statusText)
      }
    )  
    }
  } 
  EditButton(pro){
    
    if(pro==null){
      this.id=0;
      this.name="";
      this.age=null;
      this.address="";
      this.profation="";
    }
    this.id=pro.id;
    this.name=pro.name;
    this.age=pro.age;
    this.address=pro.address;
    this.profation=pro.profation;
    this.getUsrs();
  }
  }

//export class 