import {
  Component,
  OnInit,
  ViewEncapsulation,
  ViewChild,
  ElementRef
} from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { fromEvent, Observable, from, EMPTY, timer } from "rxjs";
import {
  map,
  debounceTime,
  filter,
  distinctUntilChanged,
  switchMap
} from "rxjs/operators";
import { MoviesService } from "src/app/core/services/movies.service";
import { Movie } from "src/app/core/models/movie.interface";

@Component({
  selector: "app-add-new-movie",
  templateUrl: "./add-new-movie.component.html",
  styleUrls: ["./add-new-movie.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class AddNewMovieComponent implements OnInit {
  @ViewChild("input", { read: ElementRef })
  input: ElementRef;

  private input$: Observable<any>;

  public searchResults: Movie[];

  constructor(
    private formBuilder: FormBuilder,
    private movieService: MoviesService
  ) {}

  ngOnInit() {
  }

  ngAfterViewInit() {
    this.input$ = fromEvent(this.input.nativeElement, "input").pipe(
      debounceTime(150), // Avoid reaching server rate limits by debouncing.
      map((event: KeyboardEvent) => (<HTMLInputElement>event.target).value), // Get input value
      filter(query => query.length > 2), // Continue if value.length > 2
      distinctUntilChanged(), // Search db if value is different
      switchMap(searchValue =>
        searchValue ? this.search(searchValue) : from(Promise.resolve([]))
      )
    );

    this.input$.subscribe(
      data => {
        this.searchResults = data;
      },
      error => {
        console.error(error);
      }
    );
  }

  search(value) {
    return this.movieService.search(value);
  }
}
