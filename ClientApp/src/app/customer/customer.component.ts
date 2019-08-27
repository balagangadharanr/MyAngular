import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
    selector: 'app-customer',
    templateUrl: './customer.component.html',
    styleUrls: ['./customer.component.css']
})
/** customer component*/
export class CustomerComponent {
  public customers: Customers[];
    /** customer ctor */
  constructor(http: HttpClient, @Inject('BASE_URL') baseURL: string) {
    http.get<Customers[]>(baseURL + 'api/Customer/GetCustomers').subscribe(result => {
      this.customers = result
    }, error => console.error(error));
  }
}

interface Customers {
  customerName: string;
  customerPhone: string;
  customerEmail: string;
}
