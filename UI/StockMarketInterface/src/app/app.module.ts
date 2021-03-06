import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { AdminLandPageComponent } from './Admin/admin-land-page/admin-land-page.component';
import { UserLandingPageComponent } from './User/user-landing-page/user-landing-page.component';
import { AdminLoginComponent } from './Admin/admin-login/admin-login.component';
import { UserLoginComponent } from './User/user-login/user-login.component';
import { SignUpComponent } from './User/sign-up/sign-up.component';
import { ImportComponent } from './Admin/import/import.component';
import { ManageCompanyComponent } from './Admin/manage-company/manage-company.component';
import { UpdateIPOComponent } from './Admin/update-ipo/update-ipo.component';
import { AdminService } from './Shared/admin.service';
import { ImportService } from './Shared/import.service';
import { ViewCompanyComponent } from './Admin/view-company/view-company.component';
import { ViewIPOComponent } from './Admin/view-ipo/view-ipo.component';


@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    AdminLandPageComponent,
    UserLandingPageComponent,
    AdminLoginComponent,
    UserLoginComponent,
    SignUpComponent,
    ImportComponent,
    ManageCompanyComponent,
    UpdateIPOComponent,
    ViewCompanyComponent,
    ViewIPOComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [AdminService, ImportService],
  bootstrap: [AppComponent]
})
export class AppModule { }
