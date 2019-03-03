import { NgModule } from "@angular/core";
import { MatButtonModule, MatDialogModule } from "@angular/material";
import { DeleteConfirmationDialogComponent } from "./delete-confirmation-dialog.component";

@NgModule({
  imports: [MatButtonModule, MatDialogModule],
  declarations: [DeleteConfirmationDialogComponent],
  exports: [DeleteConfirmationDialogComponent],
  entryComponents: [DeleteConfirmationDialogComponent]
})
export class DeleteConfirmationDialogModule {}
