import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CookBookService } from '../services/cook-book.service';

@Component({
  selector: 'app-edit-recipe',
  templateUrl: './edit-recipe.component.html',
  styleUrls: ['./edit-recipe.component.css']
})
export class EditRecipeComponent implements OnInit {
  queryParams: any;
  details: any;
  constructor(private activatedRoute: ActivatedRoute,private cookBookService:CookBookService,private router: Router) { }

  ngOnInit(): void {
    this.queryParams = this.activatedRoute.snapshot.queryParams;
    this.details = JSON.parse(this.queryParams["listRecipes"] || null);
  }
  editRecipeDetails(){
  this.cookBookService.addRecipeDetails(this.details).subscribe(res=>{
    alert("Recipe Updated Successfully");
     this.router.navigate(['/cook-book-list']);
  });
  }
}
