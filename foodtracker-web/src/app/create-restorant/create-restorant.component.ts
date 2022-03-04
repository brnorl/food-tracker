import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {FormBuilder} from '@angular/forms';


@Component({
  selector: 'app-create-restorant',
  templateUrl: './create-restorant.component.html',
  styleUrls: ['./create-restorant.component.css']
})
export class CreateRestorantComponent implements OnInit {
response:any;

constructor(private formBuilder:FormBuilder,private http:HttpClient) { 

  }
  restorantForm = this.formBuilder.group({
    name:[''],
    type:[''],
    province:[''],
    district:[''],
    establishment:[''],
  });
  async createRestorant(){
    //POST
    this.response=await this.http.post('https://localhost:5001/Restorant',this.restorantForm.value).toPromise();
    window.location.reload();
  }
  


  ngOnInit(): void {
  }

}
