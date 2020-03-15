import { Injectable } from '@angular/core';
import { CanActivate, Router} from '@angular/router';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  
  constructor(private authservice: AuthService, private router: Router, private alteritify: AlertifyService) {}

  canActivate(): boolean {
    if(this.authservice.loggedIn()) {
      return true;
    }

    this.alteritify.error('you shall not pass!');
    this.router.navigate(['/home']);
    return false;
  }
  
}
