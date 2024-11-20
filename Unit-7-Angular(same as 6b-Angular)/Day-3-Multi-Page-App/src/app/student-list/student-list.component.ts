import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-student-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student-list.component.html',
  styleUrl: './student-list.component.css'
})
export class StudentListComponent {
  studentNames = ["Josh", "Ashley","Ryan","Ethan", "Kendall", "Evan"]
}
