context('testesExerc', () => {

    before(() => {
        cy.visit('https://localhost:44360/CalcSimples.aspx')
    });

    
    it.only('Calc10+123', () => {       
        
        cy.get('#txtN1').type(10)
        cy.get('#txtN2').type(123)
        cy.get('input').contains('Calcular').click()        
       
               
        
        //formula
        cy.get('#lbFormulaCalculo').invoke('text').then(texto => {
         expect(texto).to.be.equal('10 + 123')
        })
        //resultado
        cy.get('#lbResultado').invoke('text').then(valortexto => {
         expect(valortexto).to.be.equal('133')
        })
        cy.get('input').contains('Limpar').click()
        cy.get('#txtN1').invoke('text').then(val =>{
         expect(val).to.be.empty
        });
        cy.get('#txtN2').invoke('text').then(val =>{
         expect(val).to.be.empty
        });
        
      });
   

     it('Calc35-25', () => {
        cy.get('#txtN1').type(35)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(25)
        cy.get('input').contains('Calcular').click()
        
        //formula
        cy.get('#lbFormulaCalculo').invoke('text').then(texto => {
         expect(texto).to.be.equal('35 - 25')
        })
        //resultado
        cy.get('#lbResultado').invoke('text').then(valortexto => {
         expect(valortexto).to.be.equal('10')
        })
        cy.get('input').contains('Limpar').click()
     });

     it('Calc5*55', () => {
        cy.get('#txtN1').type(5)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(55)
        cy.get('input').contains('Calcular').click()
        
        //formula
        cy.get('#lbFormulaCalculo').invoke('text').then(texto => {
         expect(texto).to.be.equal('5 * 55')
        })
        //resultado
        cy.get('#lbResultado').invoke('text').then(valortexto => {
         expect(valortexto).to.be.equal('275') 
         });
         cy.get('input').contains('Limpar').click()
      });

     it('Calc20/2', () => {
        cy.get('#txtN1').type(20)
        cy.get('#rbFuncao_3').click()
        cy.get('#txtN2').type(2)
        cy.get('input').contains('Calcular').click()
        
        //formula
        cy.get('#lbFormulaCalculo').invoke('text').then(texto => {
         expect(texto).to.be.equal('20 / 2')
        })
        //resultado
        cy.get('#lbResultado').invoke('text').then(valortexto => {
         expect(valortexto).to.be.equal('10')
         });
         cy.get('input').contains('Limpar').click()
      });
       
     it('Calc70--45', () => {
        cy.get('#txtN1').type(70)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(-45)
        cy.get('input').contains('Calcular').click()
        
        //formula
        cy.get('#lbFormulaCalculo').invoke('text').then(texto => {
         expect(texto).to.be.equal('70 - -45')
        })
        //resultado
        cy.get('#lbResultado').invoke('text').then(valortexto => {
         expect(valortexto).to.be.equal('115')
         });
         cy.get('input').contains('Limpar').click()
      });

     it('tabuada', () => {
        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(1)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(2)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(3)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(4)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(5)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(6)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(7)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(8)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(9)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(10)
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar').click()
      });    
});