import { Component, OnInit, ChangeDetectorRef, AfterViewInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventEmitterService } from '../event-emitter.service';
import { ProductService} from '../product/product.service';
import { CartService } from '../cart/cart.service';
import { ProductDetailService } from './productDetail.service';
import { Product } from '../product/model';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: [
    '../../assets/css/bootstrap.css',
    '../../assets/css/creditly.css',
    '../../assets/css/easy-responsive-tabs.css',
    '../../assets/css/flexslider.css',
    '../../assets/css/fontawesome-all.css',
    '../../assets/css/menu.css',
    '../../assets/css/popuo-box.css',
    '../../assets/css/style.css'
  ]
})
export class ProductDetailComponent implements OnInit, AfterViewInit {
  totalProducts = this.productService.getCartNum();
  details: Product[] = [];
  detailProduct: Product[] = [];
  listProduct: Product[] = [];
  kind!: string;
  p = 1;
  public cart = new CartService();
  constructor(
    private eventEmitterService: EventEmitterService,
    public router: Router,
    public detailsProductService: ProductDetailService,
    public productService: ProductService,
    public cdr: ChangeDetectorRef
  ) { }
  // tslint:disable-next-line:typedef
  addProductToCart = (obj: object) => {
    this.cart.addCart(obj);
    this.totalProducts = this.productService.getCartNum();
    alert('Add Product Success');
  }
  showDetail = () => {
    this.details = this.detailsProductService.showProductDetail() as Product[];
    this.details.forEach( (item: any) => {
      this.kind = item.tennhomSP;
    });
  }
  // tslint:disable-next-line:typedef
  isNew(){
    const productdetail = JSON.parse(localStorage.getItem('productdetail') || '[]');
    if ( productdetail.tinhTrang === 'New')
    {
      return true;
    }
    else{
      return false;
    }
  }
  getProductDetail = async (id: any) => {
    this.detailProduct = await this.detailsProductService.getProductDetail(id) as Product[];
    console.log(this.detailProduct);
    if (this.detailsProductService.checkLocalStorage() === true)
    {
      localStorage.removeItem('productdetail');
    }
    const productdetail = JSON.parse(localStorage.getItem('productdetail') || '[]');
    productdetail.push(this.detailProduct);
    localStorage.setItem('productdetail', JSON.stringify(productdetail));
    this.router.navigateByUrl('/', {skipLocationChange: true}).then(() =>
      this.router.navigate(['/product-detail'])
    );
    // this.router.navigateByUrl('/product-detail');
  }
  getListProduct = async () => {
    this.listProduct = await this.productService.getListProduct() as Product[];
    console.log(this.listProduct);
  }
  // tslint:disable-next-line:use-lifecycle-interface
  ngAfterViewInit(): void {
    this.totalProducts = this.productService.getCartNum();
    this.cdr.detectChanges();
    this.getListProduct();
  }
  ngOnInit(): void {
    this.showDetail();
    if (this.eventEmitterService.subsVar === undefined) {
      this.eventEmitterService.subsVar = this.eventEmitterService.
        invokeFirstComponentFunction.subscribe((obj: object) => {
          this.addProductToCart(obj);
        });
    }
  }

}
