import { TestBed } from '@angular/core/testing';
import { CanActivateFn } from '@angular/router';

import { permissionNavigateGuard } from './permission-navigate.guard';

describe('permissionNavigateGuard', () => {
  const executeGuard: CanActivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => permissionNavigateGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
