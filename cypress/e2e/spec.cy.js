describe('The Home Page', () => {
  it('successfully loads', () => {
    cy.visit('/')

    cy.get("p")
      .should("contain", "Hello world!");
  })
})
