context('testeConexao', () => {
    it('testeConexaoCalcSimplesEntradasSaidas1', () => {
        cy.visit('https://localhost:44360/CalcSimples.aspx')

        cy.get('#txtN1').type(10)
        cy.get('#txtN2').type(123)

        cy.get('input').contains('Calcular').click()

        cy.get('#lbResultado').invoke('text').then(valor => {
            expect(valor).to.be.equal('133')
        })

        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(97)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(70)

        cy.get('input').contains('Calcular').click()

        cy.get('#lbResultado').invoke('text').then(valor => {
            expect(valor).to.be.equal('27')
        })

        cy.get('input').contains('Limpar').click()  

        cy.visit('https://localhost:44360/ControleEntradasSaidas.aspx')

        cy.get('#txtN1').type('Pássaros')
        cy.get('#txtV1').type(3)
        cy.get('#txtN2').type('Peixes')
        cy.get('#txtV2').type(5)
        cy.get('#btnNovaEntradaSaida').click() 

        cy.get('table tbody tr').should('have.length', 3)

        cy.get('#btnLimpar').click()

    });

    it('testeConexaoCalcSimplesEntradasSaidas2', () => {

        cy.visit('https://localhost:44360/CalcSimples.aspx')

        cy.get('#txtN1').type(10)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(100)
        cy.get('input').contains('Calcular').click()
        cy.get('#lbResultado').invoke('text').then(valor => {
            expect(valor).to.be.equal('1000')
        })
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(90)
        cy.get('#rbFuncao_3').click()
        cy.get('#txtN2').type(3)
        cy.get('input').contains('Calcular').click()
        cy.get('#lbResultado').invoke('text').then(valor => {
            expect(valor).to.be.equal('30')
        })
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(125)
        cy.get('#txtN2').type(25)
        cy.get('input').contains('Calcular').click()
        cy.get('#lbResultado').invoke('text').then(valor => {
            expect(valor).to.be.equal('150')
        })
        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(1)
        cy.get('input').contains('Calcular').click()
        cy.get('#lbResultado').invoke('text').then(valor => {
            expect(valor).to.be.equal('1')
        })
        cy.get('input').contains('Limpar').click()

        cy.visit('https://localhost:44360/ControleEntradasSaidas.aspx')

        cy.get('#txtN1').type('Ração')
        cy.get('#txtV1').type(20)
        cy.get('#txtN2').type('Petiscos')
        cy.get('#txtV2').type(50)
        cy.get('#txtN3').type('Coleiras')
        cy.get('#txtV3').type(5)
        cy.get('#txtN4').type('Remédios')
        cy.get('#txtV4').type(5)

        cy.get('#btnNovaEntradaSaida').click() 

        cy.get('table tbody tr').should('have.length', 5)

        cy.get('#btnLimpar').click()

    })
});