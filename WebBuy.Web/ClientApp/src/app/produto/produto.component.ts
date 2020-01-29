import { Component } from "@angular/core"

@Component({
  selector: "produto",
  template:"<div class='card'><h1>Produtos!</h1><p>{{obterNome()}}</p></div>"
})
export class ProdutoComponent {

  public nome: string;
  public produtoDisponivel: boolean;

  
  public obterNome(): string {
    return "Piercing";
  }

}
