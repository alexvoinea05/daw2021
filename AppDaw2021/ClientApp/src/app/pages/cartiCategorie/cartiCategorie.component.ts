import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CartiCategorieService } from './cartiCategorie.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-cartiCategorie',
  templateUrl: './cartiCategorie.component.html'
})
export class CartiCategorieComponent implements OnInit{

  carti: Carte[];
  categorie: Categorie[];

  constructor(private cartiCategorieService: CartiCategorieService, private route: ActivatedRoute) { }
  
  
  ngOnInit(): void {
    this.route.params.subscribe(params => {
      const id = params['id'];
      this.cartiCategorieService.getCartiCategorie(id).subscribe(carti => this.carti = carti);
    })
    
  }
}

interface Carte {
  idCarte: string;
  numeCarte: string;
  descriere: string;
}

interface Categorie {
  idCategorie: string;
  numeCategorie: string;
}
