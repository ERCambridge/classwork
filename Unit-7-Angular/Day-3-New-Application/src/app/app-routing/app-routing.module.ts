import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { StudentListComponent } from '../student-list/student-list.component';
import { SampleFormComponent } from '../sample-form/sample-form.component';
import { HomeComponent } from '../home/home.component';

const routes: Routes = [ 
  { path: '', redirectTo: '/home', pathMatch: 'full' }, 
  { path: 'home', component: HomeComponent }, 
  { path: 'students', component: StudentListComponent }, 
  { path: 'contactInfo', component: SampleFormComponent }, 
  ];

@NgModule({
  declarations: [],
  imports: [CommonModule, RouterModule.forRoot(routes)],
  exports: [RouterModule] 
})
export class AppRoutingModule { }
