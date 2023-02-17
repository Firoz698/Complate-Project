import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http'
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class AppServicesService {
  constructor(private http: HttpClient) { }

//add the new code here vaia Connect With dot net Api
  config = {
    headers:{
      "Content-Type": "application/json",
    }}; 
//Post user ....dataBase a DataBase a Database pathanor Janno
  postProduct(OnjProd: any): Observable<any> {
    debugger
    return this.http.post('https://localhost:7285/api/ApplicationDemo/PostData', OnjProd,this.config)
  }

//Get Usre Database theke User Get Korar janno
  GetUsers(): Observable<any> {
    debugger
    return this.http.get('https://localhost:7285/api/ApplicationDemo/GetData',this.config)
  }

  //this Updare User ...usre Updare korar janno
  putUser( pro :any): Observable<any> {
    debugger
    return this.http.put('https://localhost:7285/api/ApplicationDemo/EditData',pro,this.config)
  } 

  //this is Remove User ...Remove korar janno
  deletedUser(id :any): Observable<any> {
    debugger
      return this.http.delete('https://localhost:7285/api/ApplicationDemo/deleted?Id='+id,this.config)
  }
}
