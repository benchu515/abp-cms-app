import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
    CMSServiceServiceProxy,
    PageDto
} from '@shared/service-proxies/service-proxies';
import { ActivatedRoute } from '@angular/router';

@Component({
    templateUrl: './cms.component.html',
    animations: [appModuleAnimation()]
})
export class CMSComponent extends AppComponentBase {

    sub: any;
    id: any;
    page: PageDto;

    constructor(
        injector: Injector,
        private route: ActivatedRoute,
        private _cmsService: CMSServiceServiceProxy
    ) {
        super(injector);
    }
    ngOnInit() {
        this.sub = this.route.params.subscribe(params => {
           this.id = +params['id']; // (+) converts string 'id' to a number
            console.log(this.id);
            this._cmsService.getCMSContent(this.id)
            .subscribe((result: PageDto) => {
                this.page = result;
            });
        });
        
    }
}
