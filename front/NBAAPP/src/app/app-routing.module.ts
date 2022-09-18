import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainMenuComponent } from './components/main-menu/main-menu.component';
import { PlayersComponent } from './components/players/players.component';

const routes: Routes = [
  { path : "menu", component:MainMenuComponent},
  { path : "players", component:PlayersComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
