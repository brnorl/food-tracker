import { HttpClient } from '@angular/common/http';
import { Component, OnInit,Input } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-create-comment',
  templateUrl: './create-comment.component.html',
  styleUrls: ['./create-comment.component.css']
})
export class CreateCommentComponent implements OnInit {
  @Input() restorantName: any;
  response:any;
  constructor(private http:HttpClient,private formBuilder:FormBuilder) { }
  commentForm = this.formBuilder.group({
    commentator:[''],
    value:[''],
    score:['']
  });

  ngOnInit(): void {
  }

  async createComment(){
    this.http.post(`https://localhost:5001/Restorant/Comment?restorantName=${this.restorantName}`,this.commentForm.value).toPromise();
    window.location.reload();
  }

}
