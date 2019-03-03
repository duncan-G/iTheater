import { Component, OnInit, Inject, ViewEncapsulation } from "@angular/core";
import { MAT_DIALOG_DATA } from "@angular/material";

@Component({
  selector: "app-delete-list-confirmation",
  templateUrl: "./delete-list-confirmation.component.html",
  styleUrls: ["./delete-list-confirmation.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class DeleteListConfirmationComponent implements OnInit {
  constructor(@Inject(MAT_DIALOG_DATA) public data: any) {}

  ngOnInit() {}
}
