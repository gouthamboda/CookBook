import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddRecipeComponent } from './add-recipe/add-recipe.component';
import { CookBookListComponent } from './cook-book-list/cook-book-list.component';
import { EditRecipeComponent } from './edit-recipe/edit-recipe.component';

const routes: Routes = [
  { path: 'cook-book-list', component: CookBookListComponent },
  { path: 'add-recipe', component: AddRecipeComponent },
  {path:'edit-recipe',component:EditRecipeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
