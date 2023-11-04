describe('The Home Page', () => {
  it('successfully loads', () => {
    cy.visit('/')

    cy.get("h1")
      .should("contain", "Posts from our API call");

    cy.get("div.card-header")
      .should("contain", "accusamus beatae ad facilis cum similique qui sunt");
  })
})
