import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CookBookService } from '../services/cook-book.service';

@Component({
  selector: 'app-cook-book-list',
  templateUrl: './cook-book-list.component.html',
  styleUrls: ['./cook-book-list.component.css']
})
export class CookBookListComponent implements OnInit {

  constructor(private cookBookService:CookBookService,private router: Router) { }
  listCookBooks:any[];
  ngOnInit(): void {
    this.getCookBookList();
  }
getCookBookList(){
  this.cookBookService.getCookBookList().subscribe(data=>{
    this.listCookBooks=data;
    console.log(data);
  });
}
editRecipe(rowData){
  console.log(rowData);
   let data={
    listRecipes:JSON.stringify(rowData)
  }
  this.router.navigate(['/edit-recipe'], {
    queryParams:data,
    skipLocationChange: true,
  });
}
addRecipe(){
  this.router.navigate(['/add-recipe']);
}
}
