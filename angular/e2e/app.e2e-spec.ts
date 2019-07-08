import { CMS_AssignmentTemplatePage } from './app.po';

describe('CMS_Assignment App', function() {
  let page: CMS_AssignmentTemplatePage;

  beforeEach(() => {
    page = new CMS_AssignmentTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
