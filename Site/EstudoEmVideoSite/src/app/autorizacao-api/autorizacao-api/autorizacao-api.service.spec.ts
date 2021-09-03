import { TestBed } from '@angular/core/testing';

import { AutorizacaoApiService } from './autorizacao-api.service';

describe('AutorizacaoApiService', () => {
  let service: AutorizacaoApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AutorizacaoApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
