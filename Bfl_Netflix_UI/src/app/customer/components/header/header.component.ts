import { Component, ElementRef, HostListener, Renderer2 } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  isNavbarTransparent = true;
isSearchClicked=false;
  constructor(private elementRef: ElementRef, private rendrer: Renderer2) {


  }





  @HostListener('window:scroll')
  onWindowScroll() {
    const ScrollTop = window.pageYOffset || document.documentElement.scrollTop || document.body.scrollTop || 0;
    this.isNavbarTransparent = ScrollTop === 0;
  }

  toggleSearch(){
    this.isSearchClicked=!this.isSearchClicked;
  }


}
