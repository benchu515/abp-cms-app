import { Component, Injector, ViewEncapsulation } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { MenuItem } from '@shared/layout/menu-item';
import {
    CMSServiceServiceProxy,
    PageDto
} from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './sidebar-nav.component.html',
    selector: 'sidebar-nav',
    encapsulation: ViewEncapsulation.None
})
export class SideBarNavComponent extends AppComponentBase {
    sub: any;
    id: any;
    pages: PageDto[];

    menuItems: MenuItem[] = [
        new MenuItem(this.l('HomePage'), '', 'home', '/app/home'),

        new MenuItem(this.l('Tenants'), 'Pages.Tenants', 'business', '/app/tenants'),
        new MenuItem(this.l('Users'), 'Pages.Users', 'people', '/app/users'),
        new MenuItem(this.l('Roles'), 'Pages.Roles', 'local_offer', '/app/roles'),
        new MenuItem(this.l('About'), '', 'info', '/app/about'),
        // Somehow you have to populate a dummy item to make it clickable. Very Strange.
        // My guess will be it has something to do with the life cycle of Angular Mateiral
        new MenuItem('Pages', '', 'my_library_books', '', [
            new MenuItem(' ', '', '', '/app/cms/1')
        ])
    ];

    constructor(
        injector: Injector,
        private _cmsService: CMSServiceServiceProxy
    ) {
        super(injector);
    }

    ngOnInit() {
                this._cmsService.getAll()
                .subscribe((result: PageDto[]) => {
                    this.pages = result;
                    let cms_menu_pos = -1;
                    this.menuItems.forEach((item, index) => {
                        if (item.name === 'Pages')
                            cms_menu_pos = index;
                    });
                    this.menuItems[cms_menu_pos].items.pop();
                    this.pages.forEach(page => {
                       this.menuItems[cms_menu_pos].addItem(new MenuItem(page.pageName, '', '', '/app/cms/'+page.id ));
                    });
                    
                });
    }

    showMenuItem(menuItem): boolean {
        if (menuItem.permissionName) {
            return this.permission.isGranted(menuItem.permissionName);
        }

        return true;
    }
}
