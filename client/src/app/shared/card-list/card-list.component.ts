import {
  Component,
  OnInit,
  Input,
  Output,
  EventEmitter,
  ViewEncapsulation
} from "@angular/core";

@Component({
  selector: "app-card-list",
  templateUrl: "./card-list.component.html",
  styleUrls: ["./card-list.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class CardListComponent implements OnInit {
  @Input() list: any;
  @Input() cardItems: any[];
  @Input() emptyListMsg: string;
  @Input() addMsg: string;
  @Output() onAdd = new EventEmitter();

  // cardItem arguments
  @Input() getImageUrl: any;
  @Input() getOnClickPath: any;
  @Input() cardHasRating: boolean;
  @Input() cardHasEdit: boolean;
  @Input() cardHasDelete: boolean;
  @Input() handleRateChange: any;
  @Input() handleEdit: any;
  @Input() handleDelete: any;

  constructor() {}

  ngOnInit() {}

  handleAddToList() {
    this.onAdd.emit();
  }
}
