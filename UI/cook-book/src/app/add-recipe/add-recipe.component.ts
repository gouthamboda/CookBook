import { JsonpClientBackend } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CookBookService } from '../services/cook-book.service';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {
title:string;
description:string;
ingredients:string;
process:string;
youTubeLink:string;
  constructor(private cookBookService:CookBookService,private router: Router) { }

  ngOnInit(): void {
    
  }
addRecipeDetails(){
  let data={
    title:this.title,
    description:this.description,
    ingredients:this.ingredients,
    process:this.process,
    youTubeLink:this.youTubeLink
  };
this.cookBookService.addRecipeDetails(data).subscribe(res=>{
  alert("Recipe Added Successfully");
   this.router.navigate(['/cook-book-list']);
});
}
}
