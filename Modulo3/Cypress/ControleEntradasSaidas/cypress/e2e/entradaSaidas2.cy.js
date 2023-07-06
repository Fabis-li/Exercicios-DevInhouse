context('EntradaSaidaEx2', () => {
    before(() => {
        cy.visit('https://localhost:44360/ControleEntradasSaidas.aspx')
    });

    it('Entrada1', () => {
        cy.get('#txtN1').type('Caneta')
        cy.get('#txtV1').type('234')
        cy.get('#txtN2').type('Folha A4')
        cy.get('#txtV2').type('530')

        cy.get('#btnNovaEntradaSaida').click()

        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1){
                        expect(nome).to.be.equal('Caneta')
                    }
                    if(index == 2){
                        expect(nome).to.be.equal('Folha A4')
                    }                   
                })              
              
            }
        })

        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pValor')
                .invoke('text').then(vlr => {
                    if(index == 1){
                        expect(vlr).to.be.equal('234')
                    }
                    if(index == 2){
                        expect(vlr).to.be.equal('530')
                    }                   
                })              
              
            }
        })

        cy.get('#lbVTotal').invoke('text').then(val => {
            expect(val).to.be.equal('Valor Total: 764')
        })

        cy.get('#btnLimpar').click()

        cy.get('#txtN1').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV1').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
        cy.get('#txtN2').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV2').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
        
    });
    it('Entrada2', () => {
        cy.get('#txtN1').type('Lápis')
        cy.get('#txtV1').type('4320')        

        cy.get('#btnNovaEntradaSaida').click()

        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1){
                        expect(nome).to.be.equal('Lápis')
                    }                  
                    
                })
            }
        })
        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pValor')
                .invoke('text').then(vlr => {
                    if(index == 1){
                        expect(vlr).to.be.equal('4320')
                    }
                                     
                })              
              
            }
        })

        cy.get('#lbVTotal').invoke('text').then(val => {
            expect(val).to.be.equal('Valor Total: 4320')
        })

        cy.get('#btnLimpar').click()

        cy.get('#txtN1').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV1').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
    });
    it('Entrada3', () => {
        cy.get('#txtN1').type('Bolsa')
        cy.get('#txtV1').type('135')
        cy.get('#txtN2').type('Caderno')
        cy.get('#txtV2').type('1200')
        cy.get('#txtN3').type('Livros')
        cy.get('#txtV3').type('1200')        

        cy.get('#btnNovaEntradaSaida').click()
        
        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1){
                        expect(nome).to.be.equal('Bolsa')
                    }
                    if(index == 2){
                        expect(nome).to.be.equal('Caderno')
                    }
                    if(index == 3){
                        expect(nome).to.be.equal('Livros')
                    }               
                    
                })
            }
        })

        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pValor')
                .invoke('text').then(vlr => {
                    if(index == 1){
                        expect(vlr).to.be.equal('135')
                    }
                    if(index == 2){
                        expect(vlr).to.be.equal('1200')
                    }
                    if(index == 3){
                        expect(vlr).to.be.equal('1200')
                    }                      
                })              
              
            }
        })
        

        cy.get('#lbVTotal').invoke('text').then(val => {
            expect(val).to.be.equal('Valor Total: 2535')
        })

        cy.get('#btnLimpar').click()

        cy.get('#txtN1').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV1').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
        cy.get('#txtN2').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV2').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
        cy.get('#txtN3').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV3').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
    });

});