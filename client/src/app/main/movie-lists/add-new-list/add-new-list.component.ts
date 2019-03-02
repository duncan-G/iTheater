import { Component, OnInit } from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { MoviesService } from "src/app/core/services/movies.service";

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
    private moviesService: MoviesService
  ) {}

  ngOnInit(): void {
    this.addNewListForm = this.formBuilder.group({
      name: ["", [Validators.required]],
      privacy: [false, Validators.required]
    });
  }

  handleSubmit() {
    this.moviesService.addMovieToList(this.addNewListForm.value);
  }

  handleSuccess(data) {
    console.log(data);
  }

  handleError(error) {
    console.error(error);
  }
}
