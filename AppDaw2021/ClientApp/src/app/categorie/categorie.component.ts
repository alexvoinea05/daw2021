import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CartiCategorieService } from '../pages/cartiCategorie/cartiCategorie.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-categorie',
  templateUrl: './categorie.component.html'
})
export class CategorieComponent {
  public Categorie: task[];
  public carti: Carte[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private cartiCategorieService: CartiCategorieService, private route: ActivatedRoute) {
    http.get<task[]>(baseUrl + 'api/categorie').subscribe(result => {
      this.Categorie = result;
    }, error => console.error(error));
  }

  cartiCategorie(id) {
    this.cartiCategorieService.getCartiCategorie(id).subscribe(carti => {
      this.carti = carti
    });
  }

    
}

interface task {
  idCategorie: string;
  genCategorie: string;
}

interface Carte {
  idCarte: string;
  numeCarte: string;
  descriere: string;
}
