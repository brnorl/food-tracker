import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-restorant-list',
  templateUrl: './restorant-list.component.html',
  styleUrls: ['./restorant-list.component.css']
})
export class RestorantListComponent implements OnInit {
  restorants:any;
  deleteResponse:any;
  randomRestorant:any;
  selectedType:any;
  restorantTypes:any;
  constructor(private http:HttpClient) { }

  
  async ngOnInit(): Promise<void> {
    this.restorants=  await this.http.get("https://localhost:5001/Restorant").toPromise();
    this.randomRestorant = this.restorants[Math.floor(Math.random() * this.restorants.length)];
    //Reducing duplicate types from object for select component
    this.restorantTypes=this.restorants.reduce((acc:any, val:any) => {
      if (!acc.find((el:any) => el.type === val.type)) {
        acc.push(val);
      }
      return acc;
    }, []);
    
    
    console.log(this.restorantTypes);
  }

  
  async delete(name:string){
   this.deleteResponse= await this.http.delete(`https://localhost:5001/Restorant?restorantName=${name}`).toPromise();
    window.location.reload();
  }

}
