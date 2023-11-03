describe('The Home Page', () => {
  it('successfully loads', () => {
    cy.visit('/')

    cy.get("p")
      .should("contain", "Hello world! This is my first React app.");
  })
})
