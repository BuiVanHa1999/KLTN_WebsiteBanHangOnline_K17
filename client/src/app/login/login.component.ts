import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
// import { stringify } from 'querystring';
import { AuthenticationService } from './authentication.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['../../assets/css/bootstrap.css',
  '../../assets/css/creditly.css',
  '../../assets/css/easy-responsive-tabs.css',
  '../../assets/css/flexslider.css',
  '../../assets/css/fontawesome-all.css',
  '../../assets/css/menu.css',
  '../../assets/css/popuo-box.css',
  '../../assets/css/style.css',
  '../../assets/css/style_login_register.css']
})
export class LoginComponent implements OnInit {
  public email = '';
  public password = '';
  data!: Account;

  constructor(
    private authenticationService: AuthenticationService,
    private router: Router
  ) { }
  login = () => {
    console.log(this.email + this.password);
    this.authenticationService.login(this.email, this.password).subscribe(
    async (data) => {
    if (data != null && data.email) {
    localStorage.setItem('email', data.email);
    localStorage.setItem('password', data.password);
    localStorage.setItem('isLogined', data.isLogined = 'true');
    console.log('login Success');
    alert('Login Success');
    if (this.authenticationService.currentUserValue.role === 'Admin')
    {
      this.router.navigateByUrl('/dashboard');
    }
    else{
      const cart = this.Cart();
      if (cart === true)
      {
        this.router.navigateByUrl('');
      }
      else
      {
        this.router.navigateByUrl('/cart');
      }
    }
    } else{
    console.log('login fail');
    alert('Login Fail');
    }
    },
    (err) => {
      console.error(err);
      alert('Login Fail');
    }
    );
  }

  // tslint:disable-next-line:typedef
  Cart(){
    if (localStorage.getItem('cart') === null)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  ngOnInit(): void {
  }

}

