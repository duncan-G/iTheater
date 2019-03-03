import { Component, OnInit, Inject, ViewEncapsulation } from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { MovieListsService } from "src/app/core/services/movie-lists.service";
import { MAT_DIALOG_DATA, MatDialogRef } from "@angular/material";

export interface IMovieListFormDialogData {
  formType: "add" | "edit";
  name?: string;
  privacy?: boolean;
  dialogTitle: string;
  submitText: string;
  movieListId?: number;
}

@Component({
  selector: "app-movie-list-form",
  templateUrl: "./movie-list-form.component.html",
  styleUrls: ["./movie-list-form.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieListFormComponent implements OnInit {
  public movieListForm: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<MovieListFormComponent>,
    @Inject(MAT_DIALOG_DATA) public data: IMovieListFormDialogData,
    private formBuilder: FormBuilder,
    private router: Router,
    private movieListService: MovieListsService
  ) {}

  ngOnInit(): void {
    this.movieListForm = this.formBuilder.group({
      name: [this.data.name || "", [Validators.required]],
      privacy: [this.data.privacy || true, Validators.required]
    });
  }

  handleSubmit() {
    if (this.data.formType === "add") {
      this.handleCreate();
    } else if (this.data.formType === "edit") {
      this.handleEdit();
    }
  }

  handleCreate() {
    this.movieListService.createMovieList(this.movieListForm.value).subscribe(
      slug => {
        this.router.navigateByUrl("/my-theater/" + slug);
        this.dialogRef.close();
      },
      error => this.handleError(error)
    );
  }

  handleEdit() {
    this.movieListService
      .updateMovieList(this.data.movieListId, this.movieListForm.value)
      .subscribe(
        () => this.dialogRef.close(),
        error => this.handleError(error)
      );
  }

  handleError(error) {
    console.error(error);
  }
}
