import { Component, OnInit,Input } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-update-restorant',
  templateUrl: './update-restorant.component.html',
  styleUrls: ['./update-restorant.component.css']
})
export class UpdateRestorantComponent implements OnInit {
  @Input() restorantName: any;
  response:any;
  constructor(private http:HttpClient,private formBuilder:FormBuilder) { }
  updateForm = this.formBuilder.group({
    name:[''],
    type:[''],
    province:[''],
    district:[''],
    establishment:['']
  });
  ngOnInit(): void {
  }
  async updateRestorant(){
    this.response= await this.http.put(`https://localhost:5001/Restorant?restorantName=${this.restorantName}`,this.updateForm.value).toPromise();
    console.log(this.response);
    if (this.response==true) {
    window.location.reload();
    }
  }

}
