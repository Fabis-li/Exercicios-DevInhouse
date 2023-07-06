context('EntradaSaidas ex1', () => {
    before(() => {
        cy.visit('https://localhost:44360/ControleEntradasSaidas.aspx')
    });

    it('Entrada1', () => {
        cy.get('#txtN1').type('Boneca')
        cy.get('#txtV1').type('4')
        cy.get('#txtN2').type('Carrinho')
        cy.get('#txtV2').type('1')
        cy.get('#txtN3').type('Doces')
        cy.get('#txtV3').type('5')
        cy.get('#txtN4').type('Refrigerante')
        cy.get('#txtV4').type('6')

        cy.get('#btnNovaEntradaSaida').click()       

        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1){
                        expect(nome).to.be.equal('Boneca')
                    }
                    if(index == 2){
                        expect(nome).to.be.equal('Carrinho')
                    }
                    if(index == 3){
                        expect(nome).to.be.equal('Doces')
                    }
                    if(index == 4){
                        expect(nome).to.be.equal('Refrigerante')
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
                        expect(vlr).to.be.equal('4')
                    }
                    if(index == 2){
                        expect(vlr).to.be.equal('1')
                    }
                    if(index == 3){
                        expect(vlr).to.be.equal('5')
                    } 
                    if(index == 4){
                        expect(vlr).to.be.equal('6')
                    }                          
                })              
              
            }
        })

        cy.get('#lbVTotal').invoke('text').then(val => {
            expect(val).to.be.equal('Valor Total: 16')
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
        cy.get('#txtN4').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV4').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
        
    });

    it('Entrada2', () => {
        cy.get('#txtN1').type('Boneca')
        cy.get('#txtV1').type('78')
        cy.get('#txtN2').type('Bolo')
        cy.get('#txtV2').type('3')
        cy.get('#txtN3').type('Doces')
        cy.get('#txtV3').type('8')
        
        cy.get('#btnNovaEntradaSaida').click()

        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1){
                        expect(nome).to.be.equal('Boneca')
                    }
                    if(index == 2){
                        expect(nome).to.be.equal('Bolo')
                    }
                    if(index == 3){
                        expect(nome).to.be.equal('Doces')
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
                        expect(vlr).to.be.equal('78')
                    }
                    if(index == 2){
                        expect(vlr).to.be.equal('3')
                    }
                    if(index == 3){
                        expect(vlr).to.be.equal('8')
                    }                                           
                })              
              
            }
        })        

        cy.get('#lbVTotal').invoke('text').then(val => {
            expect(val).to.be.equal('Valor Total: 89')
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

    it('Entrada3', () => {
        cy.get('#txtN1').type('Café')
        cy.get('#txtV1').type('2')
        cy.get('#txtN2').type('Coxinha')
        cy.get('#txtV2').type('3')
        cy.get('#txtN3').type('Pavê')
        cy.get('#txtV3').type('1')
        cy.get('#txtN4').type('Bolo Seco')
        cy.get('#txtV4').type('1')
        cy.get('#txtN5').type('Gelatina')
        cy.get('#txtV5').type('2')

        cy.get('#btnNovaEntradaSaida').click()

        cy.get('tbody tr')
        .each(($el, index, $list) => {
            if(index > 0){
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1){
                        expect(nome).to.be.equal('Café')
                    }
                    if(index == 2){
                        expect(nome).to.be.equal('Coxinha')
                    }
                    if(index == 3){
                        expect(nome).to.be.equal('Pavê')
                    }
                    if(index == 4){
                        expect(nome).to.be.equal('Bolo Seco')
                    }
                    if(index == 5){
                        expect(nome).to.be.equal('Gelatina')
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
                        expect(vlr).to.be.equal('2')
                    }
                    if(index == 2){
                        expect(vlr).to.be.equal('3')
                    }
                    if(index == 3){
                        expect(vlr).to.be.equal('1')
                    } 
                    if(index == 4){
                        expect(vlr).to.be.equal('1')
                    }
                    if(index == 5){
                        expect(vlr).to.be.equal('2')
                    }                           
                })              
              
            }
        })

        cy.get('#lbVTotal').invoke('text').then(val => {
            expect(val).to.be.equal('Valor Total: 9')
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
        cy.get('#txtN4').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV4').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
        cy.get('#txtN5').invoke('text').then(texto => {
            expect([]).to.be.empty
        })
        cy.get('#txtV5').invoke('text').then(vlr => {
            expect([]).to.be.empty
        })
       

    });
});