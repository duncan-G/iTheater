import { Component, OnInit } from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { MovieListsService } from "src/app/core/services/movie-lists.service";

@Component({
  selector: "app-add-new-list",
  templateUrl: "./add-new-list.component.html",
  styleUrls: ["./add-new-list.component.scss"]
})
export class AddNewListComponent implements OnInit {
  public addNewListForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private movieListService: MovieListsService
  ) {}

  ngOnInit(): void {
    this.addNewListForm = this.formBuilder.group({
      name: ["", [Validators.required]],
      privacy: [true, Validators.required]
    });
  }

  handleSubmit() {
    this.movieListService
      .addMovieList(this.addNewListForm.value)
      .subscribe(
        slug => this.handleSuccess(slug),
        error => this.handleError(error)
      );
  }

  handleSuccess(slug) {
    console.log(slug);
    this.router.navigateByUrl("/my-theater/" + slug);
  }

  handleError(error) {
    console.error(error);
  }
}
