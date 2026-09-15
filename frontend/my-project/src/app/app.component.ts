import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterLink, RouterOutlet],
  template: `
    <header>
      <h1>MyProject</h1>
      <nav><a routerLink="/dashboard">Dashboard</a><a routerLink="/users">Users</a></nav>
    </header>
    <router-outlet />
  `,
  styles: [`header { display: flex; justify-content: space-between; align-items: center; padding: 1rem 2rem; background: #111827; color: white; } nav { display: flex; gap: 1rem; } a { color: white; text-decoration: none; }`]
})
export class AppComponent {}
