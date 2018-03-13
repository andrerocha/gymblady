import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';

declare var $: any;

@Component({
    selector: 'auto-complete',
    templateUrl: './auto-complete.component.html'    
})
export class AutoCompleteComponent implements OnInit, AfterViewInit {

    @ViewChild('autocomplete') autocomplete: any

    public selectedItem: any;

    get Text(): string {

        return this.selectedItem.label;
    }

    get Value(): string {

        return this.selectedItem.value;
    }

    ngOnInit() {

    }

    ngAfterViewInit() {


    }

    public Load(source: Array<any>) {

        let self = this;

        $(this.autocomplete.nativeElement).autocomplete({            
            source: source,
            select: function (event: any, ui: any) {

                self.selectedItem = ui.item;
            }
        });
    }
}