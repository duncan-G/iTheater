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
  @Input() addToolTipMsg: string;
  @Input() deleteToolTipMsg: string;
  @Input() emptyListMsg: string;
  @Input() addMsg: string;
  @Output() onAdd = new EventEmitter();

  // cardItem arguments
  @Input() getImageUrl: any;
  @Input() cardIncludesRatings: boolean;
  @Input() handleRateChange: any;
  @Input() cardHasDelete: boolean;
  @Input() handleDelete: any;
  @Input() getOnClickPath: any;

  constructor() {}

  ngOnInit() {
  }

  handleAddToList() {
    this.onAdd.emit("add");
  }
}
