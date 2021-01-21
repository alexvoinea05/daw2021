import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CategorieComponent } from './categorie/categorie.component';
import { LoginComponent } from './auth/login/login.componenet';
import { RegisterComponent } from './auth/register/register.component';
import { CarteComponent } from './carte/carte.component';
import { ToastrModule } from 'ngx-toastr';
import { AuthGuard } from './core/guards/auth.guard';
import { CartiCategorieComponent } from './pages/cartiCategorie/cartiCategorie.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CarteUnitaraComponent } from './pages/carteUnitara/carteUnitara.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CategorieComponent,
    LoginComponent,
    RegisterComponent,
    CarteComponent,
    CartiCategorieComponent,
    CarteUnitaraComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    }),
    BrowserAnimationsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
          { path: 'counter', component: CounterComponent, canActivate: [AuthGuard] },
          { path: 'fetch-data', component: FetchDataComponent },
          { path: 'api/categorie', component: CategorieComponent },
          { path: 'login', component: LoginComponent },
          { path: 'api/carte', component: CarteComponent },
          { path: 'api/carte/categorie/:id', component: CartiCategorieComponent },
          { path: 'api/carte/unitara/:id', component: CarteUnitaraComponent }

        ]
      },
     
      { path: '**', component: HomeComponent, pathMatch: 'full' }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
