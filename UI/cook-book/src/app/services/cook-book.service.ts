import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class CookBookService {

  constructor(private httpClient : HttpClient) { }
getCookBookList() : Observable<any>{
  return this.httpClient.get(environment.apiURL+"CookBook/GetRecipeDetails");
}
addRecipeDetails(data:any){
return this.httpClient.post(environment.apiURL+"CookBook/AddRecipes",data);
}
}
