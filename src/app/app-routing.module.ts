import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MenuComponent} from './menu/menu.component';
import { LoginComponent} from './login/login.component';
import { InsertComponent } from './insert/insert.component';
import { UpdateComponent } from './update/update.component';
import { FindComponent } from './find/find.component';
import { DeleteComponent} from './delete/delete.component';
import { RegistrationComponent } from './registration/registration.component'


const routes: Routes = [
  {path:'',component:LoginComponent},
  {path:'login',component:LoginComponent},
  {path:'menu',component:MenuComponent},
  {path:'menu/insert',component:InsertComponent},
  {path:'menu/update',component:UpdateComponent},
  {path:'menu/find',component:FindComponent},
  {path:'menu/delete',component:DeleteComponent},
  {path:'registration',component:RegistrationComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
