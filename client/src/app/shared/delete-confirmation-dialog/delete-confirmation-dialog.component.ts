import { Component, OnInit, Inject, ViewEncapsulation } from "@angular/core";
import { MAT_DIALOG_DATA } from "@angular/material";

@Component({
  selector: "app-delete-confirmation-dialog",
  templateUrl: "./delete-confirmation-dialog.component.html",
  styleUrls: ["./delete-confirmation-dialog.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class DeleteConfirmationDialogComponent implements OnInit {
  constructor(@Inject(MAT_DIALOG_DATA) public data: any) {}

  ngOnInit() {}
}
