import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MatcherComponent } from './matcher.component';

describe('MatcherComponent', () => {
  let component: MatcherComponent;
  let fixture: ComponentFixture<MatcherComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MatcherComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MatcherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  const calculadora = {
    somar: function(n1: number, n2: number){
      return n1 + n2;
    }
  }

  beforeAll(()=> {
    spyOn(calculadora, 'somar')
  });

  it('should validate the use of Matcher SpyOn', ()=>{
    calculadora.somar(2, 3);

    expect(calculadora.somar).toHaveBeenCalled();
  })

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });

  it('should check if the objects are the same ',()=>{
    const obj1 = {value: true};
    const obj2 = {value: true};

    expect(obj1).toBe(obj1);
  });

  it('should check if the values are the same',()=>{
    expect(component.igual()).toEqual(2);
  });

  it('should validate the mobile number',()=>{
    const cel = "(11) 98765-4567";

    expect(cel).toMatch(/^\([1-9]{2}\) [9]{0,1}[6-9]{1}[0-9]{3}\-[0-9]{4}$/);
  });

  it('should validate the use of Matcher toBeDefined',()=>{
    let valor = 20;

    expect(valor).toBeDefined();
  });

  it('should validate the use of Matcher toBeUndefined',()=>{
    let valor;

    expect(valor).toBeUndefined();
  });

  it('should validate the use of Matcher toBeTruthy',()=>{
    let valor = true;

    expect(valor).toBeTruthy();
  });

  it('should validate the use of Matcher toBeFalse',()=>{
    let valor = false;

    expect(valor).toBeFalse();
  });

  it('should validate the use of Matcher toContain',()=>{
    
    expect(component.frutas()).toContain("maçã");
    expect(component.frutas()).toContain("perâ");
    expect(component.frutas()).toContain("uva");
    
  });

  it('should validate the use of Matcher toBeGreaterThan',()=>{
    const num = 20;

    expect(num).toBeGreaterThan(10);
    
  });

  it('should validate the use of Matcher toBeLessThan',()=>{
    const num = 20;

    expect(num).toBeLessThan(30);
    
  });

  
});
