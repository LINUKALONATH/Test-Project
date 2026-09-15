import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
  {
    path: 'dashboard',
    loadComponent: () => import('./features/dashboard/dashboard.component').then((module) => module.DashboardComponent)
  },
  {
    path: 'users',
    loadComponent: () => import('./features/users/user-list/user-list.component').then((module) => module.UserListComponent)
  },
  { path: '**', redirectTo: 'dashboard' }
];
