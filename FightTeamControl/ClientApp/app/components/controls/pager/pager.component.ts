import { Component } from '@angular/core';

@Component({
    selector: 'pager',
    templateUrl: './pager.component.html'    
})
export class PagerComponent {

    public pages: Array<any> = new Array<any>();
    public pageItemsCount: number = 10;
    public pagesCount: number = 0;
    public searchCallBack: any;
    public currentPage: number = 0;
    private parentContext: any;
    private totalItemsCount: number = 0;

    set PageItemsCount(value: number) {

        this.pageItemsCount = value;        
        this.pagesCount = this.totalItemsCount / this.pageItemsCount;        

        this.pages = new Array<any>();
        for (var i = 0; i < this.pagesCount; i++) {

            let page = {

                page: i + 1,
                class: ''
            };

            if (i == this.currentPage) {

                page.class = 'active';
            }

            this.pages.push(page);
        }
    }

    set TotalItemsCount(value: number) {

        this.totalItemsCount = value;
        this.pagesCount = this.totalItemsCount / this.pageItemsCount;        

        this.pages = new Array<number>();
        for (var i = 0; i < this.pagesCount; i++) {

            this.pages.push(i + 1);
        }
    }

    set SearchCallBack(callBack: any) {

        this.searchCallBack = callBack;
    }

    set ParentContext(value: any) {

        this.parentContext = value;
    }

    SearchClick(page: any): void {        

        this.pages[this.currentPage].class = '';
        
        page.class = 'active';
        this.currentPage = page.page - 1;        
        this.searchCallBack(this.parentContext, this.currentPage, this.pageItemsCount);
    }

    PreviousClick(): void {

        this.pages[this.currentPage].class = '';
        this.currentPage--;        
        this.pages[this.currentPage].class = 'active';

        this.searchCallBack(this.parentContext, this.currentPage, this.pageItemsCount);
    }

    NextClick(): void {

        this.pages[this.currentPage].class = '';
        this.currentPage++;
        this.pages[this.currentPage].class = 'active';

        this.searchCallBack(this.parentContext, this.currentPage, this.pageItemsCount);
    }    
}