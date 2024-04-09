import { Injectable, inject } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivateFn, Router, RouterStateSnapshot } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
class PermissionsService {

  constructor(private router: Router) {}

  canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
      
    let token = sessionStorage.getItem('token')
    if(token)
      return true
    this.router.navigate(['company'])
    return false
  }
}

export const permissionNavigateGuard: CanActivateFn = (route, state) => {
  return inject(PermissionsService).canActivate(route, state)
};
