
import { VehicleService } from './../services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
   makes:any;
   models:any;
   vehicle: any={};
   features:any;

  constructor(
    private vehicleService: VehicleService,
   // private featureService: FeatureService 
   ) {}

  ngOnInit() {
    this.vehicleService.getMakes().subscribe(makes=>
      {
        this.makes=makes
        console.log("MAKES",this.makes);
      });
      
    this.vehicleService.getFeatures().subscribe(features=>
      {
        if(features!='undefine'){
        this.features=features
         console.log("FEATURES",this.features)
        }
        else{
          console.log("error");
        }
         ;
      }
    );
  }

  onMakeChange(){
    var selectedMake = this.makes.find( (m:any) =>m.id==this.vehicle.make);
    this.models = selectedMake? selectedMake.models:[];
    console.log("VEHICLE",this.vehicle);
  }

}
